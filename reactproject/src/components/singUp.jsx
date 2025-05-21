
import { useState } from "react"
import { useContext } from "react"
import { Add } from "../axios/custemeraxios"
import MyContex from "../store"
export const SingUp=()=>{
   
  let users = useContext(MyContex).setCurrentUser
  let setUsers = useContext(MyContex).currentUser

const[obj,setObj]=useState({
  
    "custName": "",
    "custPassword": "",
    "creditDetails": ""
})
const[creditDetailsU,setCreditDetails]=useState("")


const creditDetailsString=(newValue,isLastFiled)=>{
  if(isLastFiled){ 
     setCreditDetails(prev=>prev+newValue)
  }
    else{
      setCreditDetails(prev=>prev+newValue+"-")
      setObj({...obj,creditDetails:creditDetailsU})
    }
};

  const addNewUser=async()=>{
    let y=await Add((obj))
    if(y.data)
      alert(`ברוך הבא למאגר הלקוחות שלנו`)
    else
    alert('ההרשמה נכשלה')
  }
   
   return <div>
        <div className="container"><br/>
          <div className="input-group input-group-lg">
            <span className="input-group-text" id="inputGroup-sizing-lg" >שם</span>
            <input type="text" className="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg" 
            onBlur={(e)=>setObj({...obj,custName:e.target.value})}
            >
            </input>
        </div>
        <br></br>
        <div className="input-group input-group-lg">
            <span className="input-group-text" id="inputGroup-sizing-lg" >סיסמה</span>
            <input type="password" className="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg"
          onBlur={(e)=>setObj({...obj,custPassword:e.target.value})}
             ></input>       </div>
            <br/>
          
          <div className="input-group input-group-lg">
            <span className="input-group-text" id="inputGroup-sizing-lg" >פרטי אשראי</span>
            <input type="text" className="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg" placeholder="****-****-****-****"
                     onBlur={(e)=>creditDetailsString(e.target.value,false)}
                  >
                    </input>
            <input type="text" className="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg" placeholder="00/00"
              onBlur={(e)=>creditDetailsString(e.target.value,false)}
            >
            </input>
            <input type="text" className="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg" placeholder="cvc"
             onBlur={(e)=>creditDetailsString(e.target.value,true)}
            >
            </input>
        </div>
        <br/>
        <button className="btn btn-primary"  
        onClick={()=>addNewUser()}
        >OK</button>
    </div>
    </div>
}