import axios from 'axios';

const http = axios.create({
    baseURL: 'http://localhost:4320/api/'
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
    getConversion(number, type) {
        return http.get(`convert?number=${number}&type=${type}`);
    }
}