import React, { useState, useEffect } from "react";
import { Button, Icon, Label, Menu, Table, TableCell } from "semantic-ui-react";
import ProductService from "../services/productService";
import { Link, NavLink } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { addToCart } from "../store/actions/cartActions";
import { toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.min.css";

export default function ProductList() {
  const [products, setProducts] = useState([]);

  const dispatch = useDispatch();

  useEffect(() => {
    let productService = new ProductService();
    productService.getProducts().then((result) => {
      setProducts(result.data.data);
      console.log(products[0]);
    }, []);
  }, []);

  const handleAddToCart = (product) => {
    dispatch(addToCart(product));
    toast.dark(`${product.productName} Sepete Eklendi!`);
  };

  return (
    <div>
      <Table celled>
        <Table.Header>
          <Table.Row>
            <Table.HeaderCell>Name</Table.HeaderCell>
            <Table.HeaderCell>Price</Table.HeaderCell>
            <Table.HeaderCell></Table.HeaderCell>
          </Table.Row>
        </Table.Header>

        <Table.Body>
          {products.map((product) => (
            <Table.Row key={product.productId}>
              <Table.Cell>
                <Link to={`/Products/${product.productName}`}>
                  {product.productName}
                </Link>
              </Table.Cell>
              <Table.Cell>{product.unitPrice}</Table.Cell>
              <Table.Cell>
                <Button onClick={() => handleAddToCart(product)}>
                  Sepete Ekle
                </Button>
              </Table.Cell>
            </Table.Row>
          ))}
        </Table.Body>

        <Table.Footer>
          <Table.Row>
            <Table.HeaderCell colSpan="3">
              <Menu floated="right" pagination>
                <Menu.Item as="a" icon>
                  <Icon name="chevron left" />
                </Menu.Item>
                <Menu.Item as="a">1</Menu.Item>
                <Menu.Item as="a">2</Menu.Item>
                <Menu.Item as="a" icon>
                  <Icon name="chevron right" />
                </Menu.Item>
              </Menu>
            </Table.HeaderCell>
          </Table.Row>
        </Table.Footer>
      </Table>
    </div>
  );
}
