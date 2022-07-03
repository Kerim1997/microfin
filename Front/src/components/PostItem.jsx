import React from "react";
import '../styles/PostItem.css';
// import HeaderDiv from './HeaderDiv';

const PostItem = (props) => {
   
   function Siteref(){
     window.open("https://www.kreditionline.com.ua/uk/krediti-onlain-na-kartku");
   }
    return  (
      <div className="Item">
        <div>
        <img className ="Image" src = {props.post?.reef} />
        </div>
       <div className="ItemPost"> {props.post?.post1} </div>
       <div  className="ItemPost"> {props.post?.post2} </div>
       <div  className="ItemPost"> {props.post?.post3} </div>
       <button className="MyButton" onClick = {Siteref}> Податы заявку</button>
       </div>
    );
};
export default PostItem;