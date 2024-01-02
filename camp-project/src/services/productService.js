import axios from "axios"
export default class ProductService {

    addProduct(product) {
        return axios.post("https://localhost:7209/api/Products/add", {...product})
    }

    getProducts() {
        return axios.get("https://localhost:7209/api/Products/getall")
    }

    getByCategoryId(id) {
        return axios.get("https://localhost:7209/api/Products/getbyid?id=" + id)
    }
} 