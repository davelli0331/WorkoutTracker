import axiom from 'axios';

class Api {
    fetch(url, callback) {
        axiom
            .get(url)
            .then((response) => {
                callback(response.data);
            });
    }

    post(url, data, callback) {
        axiom
            .post(url, data)
            .then((response) => {
                callback(response);
            });
    }
}

export default new Api();