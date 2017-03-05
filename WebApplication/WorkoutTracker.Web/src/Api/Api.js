import axiom from 'axios';

class Api {
    fetch(url, callback) {
        axiom
            .get(url)
            .then(function (response) {
                callback(response.data);
            });
    }
}

export default new Api();