import { useState } from "react"
import { useEffect } from "react"
import { useContext } from "react"
import { GetAllShoppings } from "../axios/shoppingaxios"
import MyContex from "../store"
import { GetAll } from "../axios/custemeraxios"
import { Link } from "react-router-dom"
import { Outlet } from "react-router-dom"

export const PersonalArea = () => {

  let currentUser = useContext(MyContex).currentUser

  const [list, setList] = useState([])
  const allShoppings = async () => {
    debugger
    if (list.length === 0) {
      let allShopp = (await GetAllShoppings()).data

      let allCustemers = (await GetAll()).data
      let objCustemer = allCustemers.find(x => x.custName === currentUser.name && x.custPassword === currentUser.pass)
      let shoppingsCustemer = allShopp.filter(x => x.custemerId === objCustemer.custemerId)
      if (shoppingsCustemer)
        setList(shoppingsCustemer)
      else {
        alert('נכשל')
      }
    }
  }
  useEffect(() => {
    allShoppings()
  }, [])
  return <div><h1>{currentUser.name}</h1>
    <div className="container mt-3" >
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>קוד קניה </th>
            <th>סכום</th>
            <th >תאריך קניה </th >
            <th>פרטים נוספים</th>

          </tr>
        </thead>
        <tbody>
          {list.map((x, i) => (<tr key={i}>
            <td>{x.shoppingId}</td>
            <td>{x.sumShopping}</td>
            <td>{x.dateShopping}</td>
            <td><button className="btn btn-outline-dark"><Link to={`shoppingDetails/${x.shoppingId}`}>פרטים נוספים</Link></button></td>

          </tr>))}
        </tbody>
      </table>  <Outlet></Outlet>
    </div>

  </div>
}