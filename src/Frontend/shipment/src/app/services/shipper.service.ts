import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
    providedIn: 'root'
})
export class ShipperService {

    constructor(private httpClient: HttpClient) { }

    public GetAllShipers() {
       return this.httpClient.get
        ('https://localhost:44326/api/Shipper');
    }


    public GetShiperShipment(shipperId: number) {
        return this.httpClient.get
        ('https://localhost:44326/api/Shipper/'+shipperId+'/Shipment');
    }
}
