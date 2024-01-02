import React from "react";
import { Formik, Form, Field, ErrorMessage } from "formik";
import * as Yup from "yup";
import { Button, FormField, Label } from "semantic-ui-react";
import KodlamaIoTextInput from "../utilities/customFormControls/KodlamaIoTextInput";
import ProductService from "../services/productService";

export default function ProductAdd() {
  const initialValues = {
    categoryId: 0,
    productName: "",
    unitsInStock: 0,
    unitPrice: 0,
  };

  const validationSchema = Yup.object({
    productName: Yup.string().required("Urun adi zorunlu"),
    unitPrice: Yup.number().required("Urun fiyati zorunlu"),
    unitsInStock: Yup.number().required("Urun Stok Bilgisi Zorunlu"),
    categoryId: Yup.number().required("Urun Kategorisi Zorunlu"),
  });

  const addProductService = async (product) => {
    let productService = new ProductService()
    console.log(product)
    productService.addProduct(product).catch(error => console.log(error))
  }

  return (
    <div>
      <Formik
        initialValues={initialValues}
        validationSchema={validationSchema}
        onSubmit={(initialValues) => {
            console.log(initialValues)
            addProductService(initialValues)
        }}
      >
        <Form className="ui form">
          <FormField>
            <label>Urun Adi</label>
            <KodlamaIoTextInput name="productName" placeHolder="Urun Adi"/>
          </FormField>
          <FormField>
            <label>Urun Fiyati</label>
            <KodlamaIoTextInput name="unitPrice" placeHolder="Urun Fiyati"/>
          </FormField>
          <FormField>
            <label>Urun Stok Adedi</label>
            <KodlamaIoTextInput name="unitsInStock" placeHolder="Urun Stok Adedi"/>
          </FormField>
          <FormField>
            <label>Urun Kategorisi</label>
            <KodlamaIoTextInput name="categoryId" placeHolder="Urun Kategorisi"/>
          </FormField>
          <Button color="green" type="submit">
            Urun Ekle
          </Button>
        </Form>
      </Formik>
    </div>
  );
}
