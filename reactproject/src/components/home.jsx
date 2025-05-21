import { useContext, useEffect, useState } from "react"
import { Outlet } from "react-router-dom"
import { Link } from "react-router-dom"
import { GetAllreactGames } from "../axios/gameaxios"
import MyContex from "../store"
export const  Home=()=>{
  let sal=useContext(MyContex).sal
  let setSal=useContext(MyContex).setSal
 
  const addnewItem=(g)=>{
   debugger
   let myCart=sal.find(p=>p.id==g.gameId)
   if(myCart==undefined){
    let addtosal={}
     addtosal.id=g.gameId
    addtosal.name=g.productName 
    addtosal.amount=1
    addtosal.pricePerUnit=g.price
    addtosal.totalPrice=g.price*addtosal.amount
    setSal(e=>e.concat(addtosal))
   }
   else{
    myCart.amount=myCart.amount+1;
    myCart.totalPrice=myCart.totalPrice+myCart.pricePerUnit
   }
  }
    const doSomething=async()=>{
    if(list.length==0)
    {
        let y=(await GetAllreactGames()).data
        setList(y)
    }
   }

    const[list,setList]=useState([])
    useEffect(()=>{
       doSomething()
    },[])
return <>
<div 
style={{ display: 'grid', gridTemplateColumns: 'repeat(5, 1fr)', gap: '10px' }}>
    {list.map((x,i)=>(
        <div className="container mt-3" key={i}>
        <div className="card" 
        style={{width : '300px'}}>
             <div className="card-body">
                    <h4 className="card-title">{x.productName}:{x.gameId}</h4>
                    <p className="card-text">{x.price}₪</p>
                    <Link to={`showGameDetailes/${x.gameId}`} className="btn btn-outline-dark">פרטים נוספים</Link>
                   <button onClick={()=>addnewItem(x)} className="btn btn-outline-dark">הוסף לסל</button>
                </div>
        </div>
    </div>
))}
 <Outlet></Outlet>
    </div>

    </>
}