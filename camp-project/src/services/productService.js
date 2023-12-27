import axios from "axios"
export default class ProductService{

    getProducts(){
        return axios.get("https://localhost:7226/api/Categories/getall")
    }

    getByCategoryId(id){
        return axios.get("https://localhost:7226/api/Categories/getbyid?id=" + id)
    }
} 