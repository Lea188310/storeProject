import axios from "axios"

const url="https://localhost:7287/api/Category/"

//שליפת כל האויביקטים
export const GetAllreactCategories=()=>{
    return axios.get(`${url}GetAll`)
}
//ID שליפת אוביקט לפי
export const GetreactCategoryByID=(id)=>{
    return axios.get(`${url}GetByID/${id}`)
}
//הוספה
export const AddreactCategory=(obj)=>{
    return axios.put(`${url}Add`,obj)
}
//מחיקה
export const DellreactCategory=(id)=>{
    return axios.delete(`${url}Dell/${id}`)
}
//עידכון
export const EditreactCategory=(id,obj)=>{
    return axios.post(`${url}UpdateCategory/${id}`,obj)
}