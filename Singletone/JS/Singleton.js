let singleton = Symbol();
let singletonEngorcer = Symbol();

class Singleton {
    constructor(enforcer) {
        this.LinksList = {}
        if (enforcer !== singletonEngorcer)
            throw "Instantiation failed: use Singleton.getInstance() instead of new.";
    }
    static get _instance() {
        if (!this[singleton])
            this[singleton] = new Singleton(singletonEngorcer);
        return this[singleton]
    }
    static set _instance(v){throw "Can't change constant property!"}
    static getInstance(){return this._instance;}
    
    addLink(link){
        if(this.LinksList.hasOwnProperty(link)){
            this.LinksList[link] +=1;
        }
        else{
            this.LinksList[link] = 1;
        }
    }
    printAllLinks(){
        if (Object.keys(this.LinksList).length){
            for (let link in this.LinksList)
                console.log(`Link: ${link}, links added: ${this.LinksList[link]}`);
        }
        else console.log("no links");
    }
    clearAllLinks(){
        this.LinksList = {}
        console.log("Cleared!");
    }
}

export default Singleton