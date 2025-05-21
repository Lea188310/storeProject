import axios from "axios"
 const url="https://localhost:7287/api/Shopping/"

//שליפה
export const GetAllShoppings=()=>{
    return axios.get(`${url}getAll`)
}

//עידכון
export const Add=(obj)=>{
    debugger
    return axios.put(`${url}Add`,obj)
}