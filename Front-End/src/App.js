import './App.css';
import { Fragment } from 'react';
import {Route, Routes} from 'react-router-dom';
import Home from './Components/Pages/Home';
import Users from './Components/Pages/Users';
import Items from './Components/Pages/Items';
import Navbar from './Components/UI/Layout/Navbar';

//Mostrar página de error cuando, no coincida ninguna terminación, o mostrar página "Not Found"

function App() {

  return (
    <Fragment>
        <Navbar/>
          <Routes>
          <Route path="" element={<Home/>}/>
          <Route path="/home" element={<Home/>}/>
          <Route path="/users" element={<Users/>}/>
          <Route path="/items" element={ <Items/>}/>
          <Route path="*" element={<Home/>}/>
          </Routes>
    </Fragment>
  );
}
export default App;
