import { Injectable } from '@angular/core';
import { PaymentDetail } from './payment-detail.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class PaymentDetailService {

  constructor(private http:HttpClient) { }

  readonly baseUrl = 'https://localhost:44337/api/paymentDetails';

  formData:PaymentDetail = new PaymentDetail();
  list : PaymentDetail[];

  postPaymentDetail(){
    return this.http.post(this.baseUrl, this.formData)
  }

  putPaymentDetail(){
    return this.http.put(`${this.baseUrl}/${this.formData.paymentDetail_Id}`,this.formData);
  }

  deletePaymentDetail(id:number){
    return this.http.delete(`${this.baseUrl}/${id}`);
  }

  refreshList(){
    this.http.get(this.baseUrl)
    .toPromise()
    .then(res => this.list = res as PaymentDetail[])
  }
}
