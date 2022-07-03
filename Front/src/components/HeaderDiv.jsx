import React from "react";
import '../styles/HeaderDiv.css';


const HeaderDiv = function(){
    return (
        <div className="HeaderDiv">
            <div className="Logo"> 
            <img src="https://i.ibb.co/NrGRqpx/image.png" alt="image" className="LogoImage" border="0"></img>
            </div>
            <div>
                <button>Enter</button>
            </div>
        </div>
    )
}
export default HeaderDiv;