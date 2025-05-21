import { useState } from "react"
import { useEffect } from "react"
import { useParams } from "react-router-dom"
import { GetAll } from "../axios/shoppingDetailsaxios"
import { Outlet } from "react-router-dom"
export const ShoppingDetailes = () => {

  const [list, setList] = useState([])
  let pCode = useParams().code

  const shoppD = async () => {
    if (list.length === 0) {
      debugger
      let p = (await GetAll()).data
      console.log(p)
      if (p) {
        setList(p)
      }
      else {
        alert('נכשל')
      }

    }
  }
  useEffect(() => {
    shoppD()
  }, [])


  return <div>
    ShoppingDetailes
    <div className="container mt-3" >
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>קוד פרטי קניה </th>
            <th > קוד מוצר </th >
            <th>כמות </th>

          </tr>
        </thead>
        <tbody>

          {list.map((x, i) => x.shoppingId == pCode && (<tr key={i}>
            <td>{x.shoppingDetailsId}</td>
            <td>{x.gameId}</td>
            <td>{x.quantity}</td>

          </tr>))}
        </tbody>
      </table>  <Outlet></Outlet>
    </div>

  </div>


}