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
        <Link to='/fo'>Press me</Link>
    <HeaderDiv/>
    <Routes>
      <Route path='/' element={<App/>}/>
      <Route path='/fo' element={<MyFooter/>}/>
      
    </Routes>
    <MyFooter/>
   </Router>

   </div>)
    , document.getElementById('root')
)

