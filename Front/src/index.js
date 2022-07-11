import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';
import {BrowserRouter as Router, Routes,Route,Link} from 'react-router-dom';
import MyFooter from './components/MyFooter';
import HeaderDiv from './components/HeaderDiv';
import './styles/StartPage.css';



ReactDOM.render((
   <div className="StartPage">
    
    <Router>
      
    <HeaderDiv/>
    <Routes>
      <Route path='/' element={<App/>}/>
      
      
    </Routes>
    <MyFooter/>
   </Router>

   </div>)
    , document.getElementById('root')
)

