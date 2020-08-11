import axios from 'axios';

const http = axios.create({
    baseURL: process.env.baseURL
})

export default {
    /**
     * Gets ReturnedNumbers Object
     * 
     * @param {String} number 
     * @param {String} type 'i' base 10, 'b' binary, 'h' hexadecimal, 'rn' roman numeral
     * 
     * @returns {Object} 
     */
    getConversion(number, type){
        http.get(`convert?number=${number}&type=${type}`);
    }
}