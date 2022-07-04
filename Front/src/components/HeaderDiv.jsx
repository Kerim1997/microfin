import React from "react";
import '../styles/HeaderDiv.css';
import {Link} from 'react-router-dom';


const HeaderDiv = function(){
    return (
        <div className="HeaderDiv">
            <div className="Logo"> 
            <img src="https://i.ibb.co/NrGRqpx/image.png" alt="image" className="LogoImage" border="0"></img>
            </div>
            <div>
                <Link to = '/fo'><button>Enter</button></Link>
         
            </div>
        </div>
    )
}
export default HeaderDiv;