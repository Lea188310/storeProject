import { Route, Routes } from "react-router-dom"
import { Connect, SingUp } from "./singUp"
import { Home } from "./home"
import { Login } from "./login"
import { ManagerCategories } from "./managerCategories"
import { ManagerGames } from "./managerGames"
import { PersonalArea } from "./personalArea"
import { ShoppingCart } from "./shoppingCart"
import { ShowGameDetailes } from "./showGameDetailes"
import { UpdateCategory } from "./updateCategory"
import { UpdateGame } from "./updateGame"
import { AddGame } from "./addGame"
import { AddCategory } from "./addCategory"
import { ShoppingDetailes } from "./shoppingDetailes"
import { Pay } from "./pay"

export const MyRouting = () => {
    return <div>
        <Routes>
            <Route path="/" element={<Home></Home>}></Route>
            <Route path="home" element={<Home></Home>}>
                <Route path="showGameDetailes/:id" element={<ShowGameDetailes></ShowGameDetailes>}></Route>
            </Route>
            <Route path="login" element={<Login></Login>}></Route>
            <Route path="categoriesM" element={<ManagerCategories></ManagerCategories>}>
                <Route path="updateCategory/:id" element={<UpdateCategory></UpdateCategory>}></Route>
                <Route path="addCategory" element={<AddCategory></AddCategory>}></Route>

            </Route>
            <Route path="gamesM" element={<ManagerGames></ManagerGames>}>
                <Route path="updateGame/:id" element={<UpdateGame></UpdateGame>}></Route>
                <Route path="addGame" element={<AddGame></AddGame>}></Route>
            </Route>
            <Route path="shoppingCart" element={<ShoppingCart></ShoppingCart>}>
                 <Route path="pay" element={<Pay></Pay>}></Route>
            </Route>
            <Route path="singUp" element={<SingUp></SingUp>}></Route>
            <Route path="personalArea" element={<PersonalArea></PersonalArea>}>
                <Route path="shoppingDetails/:code" element={<ShoppingDetailes></ShoppingDetailes>}></Route>
            </Route>
      
        </Routes>

    </div>
}