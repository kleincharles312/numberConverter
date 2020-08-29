export default {
    convertDecimalToBinary(num) {
        // this converts floats as if they were ints
        num = parseInt(num);
        if (num == NaN || num == undefined) {
            return 'Invalid Format';
        } else if (num === 0) {
            return '0';
        }

        let reducer = num;
        let result = '';
        while (reducer != 0) {
            result = (reducer % 2).toString() + result;
            reducer /= 2;
        }

        return result;
    }
}