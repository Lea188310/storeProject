import { useEffect } from "react"
import { useState } from "react"
import { AddreactCategory } from "../axios/CategoryAxios"

export const AddCategory=()=>{
   
 const[obj,setObj]=useState({
    "categoryName": ""
 })
 const addToServer=async()=>{
    let y=(await AddreactCategory(obj))
    if(y.data)
    alert("הצלחת")
    else
    alert("נכשלת")
 }
 return<div>
        <input type={'text'}placeholder="name" onBlur={(e)=>setObj({...obj,categoryName:e.target.value})}/>
  <input type={'button'} onClick={()=>addToServer()} value="שמור"/>
    </div>
}