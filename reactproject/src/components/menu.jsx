
import { useContext } from "react"
import {NavLink} from "react-router-dom"
import MyContex from "../store"
export const  Menue=()=>{
//  אם מנהל
  let isManager=useContext(MyContex).isManager
 
  let curentUser=useContext(MyContex).curentUser
  
  // אם מחובר
let isLogin=useContext(MyContex).isLogin

    return  <><ul className="nav nav-tabs">
  
    <li className="nav-item">
      <NavLink className="nav-link" to={'home'}>בית </NavLink>
    </li>
    <li className="nav-item">
      <NavLink className="nav-link" to={'login'}>התחבר</NavLink>
    </li>
    {isManager && <li className="nav-item">
      <NavLink className="nav-link" to={'gamesM'}> משחקים-מנהל</NavLink>
    </li>}
    {isManager &&<li className="nav-item">
      <NavLink className="nav-link" to={'categoriesM'}>  קטגוריות-מנהל</NavLink>
    </li>}
    <li className="nav-item">
      <NavLink className="nav-link" to={'shoppingCart'}>סל קניות 🛒</NavLink>
    </li>
    <li className="nav-item">
      <NavLink className="nav-link" to={'singUp'} >הרשם</NavLink>
    </li>
 {isLogin && <li className="nav-item">
      <NavLink className="nav-link" to={'personalArea'}>איזור אישי 👤
</NavLink>
    </li>
    }
  </ul>
  <ul></ul>
 </>
}