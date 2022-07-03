import React from "react";
import "../styles/MyFooter.css"



const MyFooter = function(){
    return (
        <div className="Footer">
            <div className="FirstDiv">
                <div className="SecondDiv">
                <p>Микрозайм  порівняння онлайн кредиторів. Швидко, зручно і просто вибери найбільш відповідний позику.</p>
                </div>
                <div className="SecondDiv">
                <p> © 2022 Микрозайм.com.ua</p>
                </div>
            </div>
                <div className="SecondDiv">
                <p>Підприємство</p>
                <p>Про нас</p>
                <p>Поширені запитання</p>
                <p>Відгуки</p>
                <p>Контакти</p>
                </div>
                <div className="SecondDiv">
                <p>Порівняти кредиторів</p>
                <p> На картку</p>
                <p>Готівкою</p>
                <p>Споживчі кредити</p>
                <p>Кредити онлайн</p>
                </div>
            
        </div>
    )
}
export default MyFooter;