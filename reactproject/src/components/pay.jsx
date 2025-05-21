import MyContex from "../store"
import { useContext } from "react"
import { GetAll, ifExist } from "../axios/custemeraxios"
import { useNavigate } from "react-router-dom"
import { Add } from "../axios/shoppingaxios"
import { useState } from "react"
import { async } from "q"
import { useEffect } from "react"
import { Addnew } from "../axios/shoppingDetailsaxios"
export const Pay = () => {
  const navigate = useNavigate();

  // אם מחובר
  let isLogin = useContext(MyContex).isLogin
  let setIsLogin = useContext(MyContex).setIsLogin
  //  סל
  const sal = useContext(MyContex).sal
  // רשימת לקוחות
  let setcurentUser = useContext(MyContex).setCurrentUser
  debugger
  let currentUser = useContext(MyContex).currentUser
  // // משתמש
  const [user, setUser] = useState({ pass: '', name: "" })
 
  let finalSum=0
  let shoppingCode=0
  const updateCust = async (code) => {

    for (let i = 0; i < sal.length; i++) {
      finalSum += sal[i].totalPrice
    }
    buy.sumShopping = finalSum
    buy.custemerId = code

    debugger
    shoppingCode = (await Add(buy)).data
    if (shoppingCode) {
      alert(`${shoppingCode}`)
      addToShopppingDetail()
    }
    else {
      alert("נכשלת")
    }


  }
  const addToShopppingDetail = async () => {
    debugger
    let sa = await Addnew(shoppingCode, sal)
    if (sa.data) {
      alert('2נרשם במערכת')
    }
    else {
      alert("נכשלת")
    }

  }


  const [buy, setBuy] = useState({
    "shoppingId": 0,
    "custemerId": 0,
    "dateShopping": "2025-01-08T16:22:51.812Z",
    "sumShopping": 0
  })

  const checkUser = async () => {
    debugger
    if (isLogin) {
      user.name = currentUser.name
      user.pass = currentUser.pass

      let y = await ifExist(user.pass, user.name)
      if (y.data) {
        let p = await GetAll()
        if (p.data) {
          buy.custemerId = p.data.find(c => c.custName == user.name && c.custPassword == user.pass).custemerId
          alert(` buy.custemerId:${buy.custemerId}
          `)
          updateCust(buy.custemerId)

        }
        else
          alert('1נכשלת')
      } else {
        alert('2נכשלת')
      }
    }
    else {
      alert('אינך מחובר ,הינך מועבר להרשמה')
      navigate("/singUp")
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