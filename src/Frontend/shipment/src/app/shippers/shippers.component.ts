import { Component } from '@angular/core';
import { ShipperService } from '../services/shipper.service';

@Component({
  selector: 'app-shippers',
  templateUrl: './shippers.component.html',
  styleUrls: ['./shippers.component.css']
})
export class ShippersComponent {

  public shipperList: any[] = [];
  public shipments: any[] = [];
  constructor(private _shipperService: ShipperService) {
    this._FetchAllShippers();
  }

  private _FetchAllShippers(): void{
    this._shipperService.GetAllShipers()
    .subscribe(
      (shippers: any) =>{
          this.shipperList = shippers;
      },
      ()=>{
          alert('Unable to fetch shippers list!!');
      }
    );
  }

  public FetchShipperShipments(supplierId: number): void{
    this._shipperService.GetShiperShipment(supplierId)
    .subscribe(
      (shipments: any) =>{
          this.shipments = shipments;
      },
      ()=>{
          alert('Unable to fetch shippers list!!');
      }
    );
  }

}
