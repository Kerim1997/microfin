import { useEffect, useState } from "react";
import { getExchangeRateAsync } from '../API/Private.Api';

export function useExchangeRate() {
    const [exchangeRates, setExchangeRates] = useState([]);
    useEffect(() => {
        async function init() {
            var rate = await getExchangeRateAsync()
            setExchangeRates(rate);
            console.log(rate);
        }

        init();
    }, [])

    return exchangeRates;
} 