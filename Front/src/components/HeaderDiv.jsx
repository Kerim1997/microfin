import React from "react";
import '../styles/HeaderDiv.css';
import { useEffect, useState } from "react";
import { useExchangeRate } from '../hooks/exchange.rate.hook';


const HeaderDiv = function(){
    const exchangeRates = useExchangeRate();
    if (exchangeRates == null || exchangeRates.lenght == 0) return ('Loading...');
    return (
        <div className="HeaderDiv">
            <div className="Logo"> 
            <img src="https://i.ibb.co/NrGRqpx/image.png" alt="image" className="LogoImage" border="0"></img>
            </div>
            <div className="Kurs">{
                
                exchangeRates.map(rate => (
                    <div key={rate.ccy}>
                        <span style={{ marginLeft: "5px" }}>{rate.ccy}</span>
                        <span style={{ marginLeft: "5px" }}>{rate.buy} /</span>
                        <span style={{ marginLeft: "5px" }}>{rate.sale}</span>
                    </div>
                ))}
            </div>
        </div>
    )
}
export default HeaderDiv;