import logo from './logo.svg';
import './App.css';
import {BrowserRouter} from "react-router-dom"
import { Menue } from './components/menu';
import { MyRouting } from './components/myrouting';
import { useState } from 'react';
import { Myprovider } from './store';

function App() {
const [currentUser,setCurrentUser]=useState({})
const [ismanager,setisManager]=useState(false)
const [sal,setSal]=useState([])
const[Isuser,setIsUser]=useState(false)
const[isLogin,setIsLogin]=useState(false)
 
const store={
isManager:ismanager,
setIsManager:setisManager,
currentUser:currentUser,
setCurrentUser:setCurrentUser,
Isuser:Isuser,
setIsUser:setIsUser,
sal:sal,
setSal,setSal,
isLogin:isLogin,
setIsLogin:setIsLogin,

}
  return (
    <div >
      <Myprovider value={store}>
    <BrowserRouter>
    <Menue></Menue>
    <MyRouting></MyRouting>
    </BrowserRouter>
    </Myprovider>
    </div>
  );
}

export default App;
