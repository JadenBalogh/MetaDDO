import app from 'firebase/app';
import 'firebase/firestore';

const config = {
    apiKey: "AIzaSyABE8zM5SKyz6szKDPAFlHgyRmyHmJr6Y0",
    authDomain: "my-app-14e78.firebaseapp.com",
    databaseURL: "https://my-app-14e78.firebaseio.com",
    projectId: "my-app-14e78",
    storageBucket: "my-app-14e78.appspot.com",
    messagingSenderId: "611119834260",
};

class Firebase {
    constructor() {
        app.initializeApp(config);

        this.db = app.firestore();
    }

    getEffects = () => this.db.collection('effects').get();

    getEffect = id => this.db.doc(`effects/${id}`);
    getStatName = id => this.db.doc(`statNames/${id}`).get();
    getStackingType = id => this.db.doc(`stackingTypes/${id}`).data().name;
}

export default Firebase;