import { useEffect } from "react"
import { useState } from "react"
import {GetAllreactGames} from "../axios/gameaxios"
import {AddreactGame} from "../axios/gameaxios"
import {GetAllreactCategories} from "../axios/CategoryAxios"
export const AddGame=()=>{
    const[category,setCategory]=useState([]
    )

const f1=async()=>{
    if(category.length==0)
    {
        let y=(await GetAllreactCategories()).data
        setCategory(y)
    }
}
useEffect(()=>{
    f1()
},[])

  const[obj,setObj]=useState({
    "gameId": 0,
    "productName": "",
    "categorId": 0,
    "price": 0,
    "pecture": "",
    "quantity": 0
  }) 
  const getFromServer=async()=>{
    let y=(await AddreactGame(obj))
    if(y.data)
    alert('הצלחת')
    else{
        alert('נכשלת')
    }
  }
  return<div>
    <h3>הוספת מוצר</h3>

      <div><input type={"text"}  className="form-control" placeholder="name" onBlur={(e)=>setObj({...obj,productName:e.target.value})} />
    
           <select className="form-select" onBlur={(e) => setObj({ ...obj, categorId: e.target.value })}>
        {category.map((e) => <option value={e.categorId}>{e.categorId}:{e.categoryName}</option>)}
      </select>


     <input type={"number"} className="form-control" placeholder="price" onBlur={(e)=>setObj({...obj,price:e.target.value})} />
     <input type={"text"}  className="form-control" placeholder="img" onBlur={(e)=>setObj({...obj,pecture:e.target.value})}/>
     <input type={"number"}  className="form-control" placeholder="quantity" onBlur={(e)=>setObj({...obj,quantity:e.target.value})} />
     <input type={"button"} className="btn btn-outline-dark"  onClick={()=>getFromServer()} value="שמור"/></div>
     
    </div>
}