import { useState } from "react"
import { useContext } from "react"
import { useNavigate } from "react-router-dom"
import { Link } from "react-router-dom"
import { ifExist } from "../axios/custemeraxios"
import MyContex from "../store"

export const Login = () => {
  const mynevigate = useNavigate()

  const [txt, setTxt] = useState("")
  const [pass, setPass] = useState("")
  //אם מנהל
  let IsManager = useContext(MyContex).isManager
  let setIsManager = useContext(MyContex).setIsManager
// רשימת לקוחות
  let setcurentUser = useContext(MyContex).setCurrentUser
  let currentUser = useContext(MyContex).currentUser
  // אם לקוח
  let isCurrUser = useContext(MyContex).Isuser
  let setIsCurrUser = useContext(MyContex).setIsUser
// אם מחובר
let isLogin=useContext(MyContex).isLogin
let setIsLogin=useContext(MyContex).setIsLogin
 
const checkUser = async () => {
    if (currentUser.name === 'm' && currentUser.pass === '1') {
      alert(' מנהל ברוך הבא')
      setIsManager(true)
    }
    else {
      debugger
      let y = await ifExist(currentUser.pass, currentUser.name)
      debugger
      if (y.data) {
        alert(` ${currentUser.name} ברוך הבא`)
       
        setIsCurrUser(true)
        setIsLogin(true)
      }
      else {
        setIsLogin(true)
        alert('הינך מועבר להרשמה')
        mynevigate("/singUp")
      }
     
    }
   
  }
  return <div className="container"><br />
    <div className="input-group input-group-lg">
      <span className="input-group-text" id="inputGroup-sizing-lg" >name</span>
      <input type="text" className="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg"
        onBlur={(e) => setcurentUser({ ...currentUser, name: e.target.value })}></input>
    </div>
    <br></br>
    <div className="input-group input-group-lg">
      <span className="input-group-text" id="inputGroup-sizing-lg" >passWord</span>
      <input type="password" className="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-lg"
        onChange={(e) => setcurentUser({ ...currentUser, pass: e.target.value })}
      ></input>
    </div>
    <button className="btn btn-primary" onClick={() => checkUser()}>OK</button>
  </div>
}