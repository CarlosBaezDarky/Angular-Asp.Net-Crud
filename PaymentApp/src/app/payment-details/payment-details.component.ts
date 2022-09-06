import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { PaymentDetail } from '../shared/payment-detail.model';
import { PaymentDetailService } from '../shared/payment-detail.service';

@Component({
  selector: 'app-payment-details',
  templateUrl: './payment-details.component.html',
  styleUrls: []
})
export class PaymentDetailsComponent implements OnInit {

  constructor(public services: PaymentDetailService, 
      private toast:ToastrService
    ) { }

  ngOnInit(): void {
    this.services.refreshList();
  }

  populateForm(selectedRecord:PaymentDetail){
    this.services.formData = Object.assign(selectedRecord);
  }

  onDelete(id:number){
    if(confirm('Are you sure to delete this record?'))
    {
    this.services.deletePaymentDetail(id).subscribe(
      res=>{
        this.services.refreshList();
        this.toast.error("Deleted successfully", "Payment Detail Register");
        
      },
      err => {console.log(err)}
    );
    }
  }

}
