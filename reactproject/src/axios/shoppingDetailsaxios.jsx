import axios from "axios"
    const url="https://localhost:7287/api/ShoppingDetail/"

//שליפה
export const GetAll=()=>{
    return axios.get(`${url}GetAll`)
}

//עידכון
export const Addnew=(id,sal)=>{
    return axios.put(`${url}add?code=${id}`,sal)
}