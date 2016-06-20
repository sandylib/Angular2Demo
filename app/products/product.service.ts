import { Injectable } from 'angular2/core';
import { IProduct } from './product';
import { Http, Response } from 'angular2/http';
import { Observable } from 'rxjs/Observable';

@Injectable() // working with constructor to do injection
export class ProductService {
    private _productUrl = 'api/products/products.json';

    constructor(private _http: Http) { }//dependence inject

    getProducts(): Observable<IProduct[]> { //es6 function to define type of data is observable
        return this._http.get(this._productUrl)
                    .map((response: Response) => <IProduct[]>response.json()) //arrow function, tranceform response to json object and is array of IProduct[]
                    .do(data => console.log("All: " + JSON.stringify(data))) //for debug
                    .catch(this.handleError);
    }

    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error');
    }

}