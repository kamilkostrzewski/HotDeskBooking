import { FormControl, FormGroup, Validators, FormBuilder } from '@angular/forms';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-booking',
  templateUrl: './booking.component.html',
  styleUrls: ['./booking.component.scss'],
})
export class BookingComponent implements OnInit {
  readonly workDaysToBook: number = 9;
  minDate: Date;
  maxDate: Date;
  formDateGroup: FormGroup;
  formOfficeGroup: FormGroup;
  formDeskGroup: FormGroup;

  constructor(private _formBuilder: FormBuilder) {
    this.minDate = new Date();
    this.maxDate = this.addDaysWithoutWeekend(new Date(), this.workDaysToBook);
  }
  ngOnInit(): void {
    this.formDateGroup = this._formBuilder.group({
      date: ['', Validators.required],
    });
    this.formOfficeGroup = this._formBuilder.group({
      office: ['', Validators.required],
    });
    this.formDeskGroup = this._formBuilder.group({
      desk: ['', Validators.required],
    });
  }

  public dateFilter(date: Date | null): boolean {
    const day = date?.getDay();
    return day !== 0 && day !== 6;
  }

  private addDays(date: Date, days: number): Date {
    date.setDate(date.getDate() + days);
    return date;
  }

  private addDaysWithoutWeekend(date: Date, days: number): Date {
    for (let index = 0; index < days; index++) {
      const dayDate = this.addDays(new Date(), index).getDay();
      if (dayDate === 0 || dayDate === 6) {
        days++;
      }
    }
    date.setDate(date.getDate() + days);
    return date;
  }
}
