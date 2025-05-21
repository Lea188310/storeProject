import { useEffect } from "react"
import { useState } from "react"
import { useParams } from "react-router-dom"
import { EditreactCategory} from "../axios/CategoryAxios"

export const UpdateCategory=()=>{
let p=useParams()
  const[obj,setObj]=useState({
    "categorId": 0,
    "categoryName": ""
  }) 
const add=async()=>{
  debugger
  let y=(await EditreactCategory(p.id,obj))
  if(y.data)
    alert('הצלחת')
  else
    alert("נכשלת")
}
return <>
    <div> 
<input type={'number'} placeholder={"categoryID"} onBlur={(e)=>setObj({...obj,categorId:e.target.value})}/> 
<input type={'text'} placeholder={"nameCategory"} onBlur={(e)=>setObj({...obj,categoryName:e.target.value})}/> 
   <input type={"button"} onClick={()=>add()} value={"שמור"}/></div>
   </>
}