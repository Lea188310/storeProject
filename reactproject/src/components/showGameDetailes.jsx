import { useEffect, useState } from "react"
import { GetreactByID } from "../axios/gameaxios"

import { useParams } from "react-router-dom"
import { useNavigate } from "react-router-dom"

export const ShowGameDetailes=()=>{
   let p=useParams()
   const navigate=useNavigate()
   
   const getFromServer=async()=>{
        if(list.length==0)
        {
            let y=(await GetreactByID(p.id)).data
            setList(y)
        }
        else{
            alert("לא נמצא משחק עם מזהה זה");
            navigate("/home")
        }
       }
        const[list,setList]=useState([])

        useEffect(()=>{
            getFromServer()
        },[])
    // פונקציה לסגירת החלון
    const handleClose = () => {
        navigate("/home");
    };
    if(list){
 return (
            <div style={{
                position: 'fixed', top: '0', left: '0', width: '100%', height: '100%', backgroundColor: 'rgba(0,0,0,0.7)', display: 'flex',
                justifyContent: 'center', alignItems: 'center', zIndex: '1000'
            }}>
                <div style={{
                    backgroundColor: 'white', padding: '20px', borderRadius: '8px', width: '80%', maxWidth: '600px'
                }}>
                    <button className="btn-close" aria-label="Close" onClick={handleClose}></button>
                    <h2>{list.productName}</h2>
                    <p><strong>מחיר:</strong> {list.price}₪</p>
                    <p><strong>תיאור:</strong> {
                  
                    'אין תיאור זמין'}</p>
                    <img src={`https://localhost:7287/${list.pecture}`} alt={list.productName} style={{ width: '100%', height: 'auto' }} />
                    <br />
                         </div>
            </div>
        );


}
}