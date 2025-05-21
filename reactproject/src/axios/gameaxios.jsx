import axios from "axios"

const url="https://localhost:7287/api/Game/"
//שליפה
export const GetAllreactGames=()=>{
    return axios.get(`${url}GetAll`)
}
//  ID שליפה לפי 
export const GetreactByID=(id)=>{
    return axios.get(`${url}GetByGameID/${id}`)
}
// שליפה משחק
export const GetreactGame=(id)=>{
    return axios.get(`${url}GetGategoryByid/${id}`)
}
// מחיקה
// /Dell/1
export const deletereactGame=(id)=>{
    return axios.delete(`${url}Dell/${id}`)
}
// // עידכון
export const updatereactGame=(id,obj)=>{
    return axios.post(`${url}UpdateGame?id=${id}`,obj)
}
// הוספה
export const AddreactGame=(obj)=>{
    return axios.put(`${url}Add`,obj)
}
