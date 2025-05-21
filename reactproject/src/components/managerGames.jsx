import { useEffect, useState } from "react"
import { Outlet } from "react-router-dom"
import { Link } from "react-router-dom"
import { GetAllreactGames } from "../axios/gameaxios"
import { UpdateGame } from "./updateGame"
import { deletereactGame } from "../axios/gameaxios"
export const ManagerGames = () => {
    // כפתור הוספת מוצר
    const addProduct = () => {
    
    }
    //    מחיקת משחק
    const deleteProduct = async (id) => {
        let z =window.confirm('האם אתה בטוח שברצונך למחוק פריט זה?')
        if (z) {
            let y = (await deletereactGame(id))
            if (y)
                alert('succses')
            else
                alert('no succses')
        }
        else
        alert("המחיקה התבטלה")
    }
    //שליפת הכל
    const getFromServer = async () => {
        if (list.length == 0) {
            let y = (await GetAllreactGames()).data
            setList(y)
        }
    }
    const [list, setList] = useState([])
    useEffect(() => {
        getFromServer()
    }, [])
    return <><div className="container mt-3">
        <h1>כל המוצרים</h1>
        <table className="table table-bordered">
            <thead>
                <tr>
                    <th>קוד מוצר</th>
                    <th>שם המוצר</th>
                    <th>קטגוריה</th>
                    <th>מחיר</th>
                    <th>תמונה</th>
                    <th>כמות</th>
                    <th>עידכון מוצר</th>
                    <th>מחיקה</th>
                </tr>
            </thead>
            <tbody>
                {list.map((x, i) => (<tr key={i}>
                    <td>{x.gameId}</td>
                    <td>{x.productName}</td>
                    <td>{x.categorId}</td>
                    <td>{x.price}₪</td>
                    <td> <img className="card-img-top" style={{ width: '100px' }} src={`https://localhost:7287/${x.pecture}`}></img></td>
                    <td>{x.quantity}</td>
                    <td><Link className="btn btn-outline-dark" to={`updateGame/${x.gameId}`}>📝</Link></td>
                    <td><button onClick={() => { deleteProduct(x.gameId) }} className="btn btn-outline-dark">🗑️</button></td>
                    </tr>))}
            </tbody>
        </table>
        <Outlet></Outlet>
        <div>  <Link to={`addGame`} className="btn btn-outline-dark" 
        >הוספת מוצר</Link>
        
            </div>

    </div>
    </>
}