import React from "react";
import "../styles/TextItem.css"


const TextItem = (props) => {
return(
    <div className="DataText">      
        <h3>{props.content?.header}</h3>
        <p> {props.content?.text} </p>
      
    </div>
 
);
};
export default TextItem;