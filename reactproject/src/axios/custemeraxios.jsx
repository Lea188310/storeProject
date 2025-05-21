import axios from "axios"

const url="https://localhost:7287/api/Custemer/"

//שליפה
export const GetAll=()=>{
    return axios.get(`${url}GetAll`)
}

// הוספה
export const Add=(obj)=>{
    return axios.put(`${url}Add`,obj)
}

//בדיקה אם קיים 
export const ifExist=(pass,name)=>{
    return axios.get(`${url}ifExist/${pass}/${name}`,pass,name)
}