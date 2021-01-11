import { HistoryComponent } from './main/history/history.component';
import { BookedComponent } from './main/booked/booked.component';
import { BookingComponent } from './main/booking/booking.component';
import { MainComponent } from './main/main.component';
import { HomeComponent } from './home/home.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NotfoundComponent } from './notfound/notfound.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  {
    path: 'main',
    component: MainComponent,
    children: [
      {
        path: '',
        component: BookingComponent,
      },
      {
        path: 'booking',
        component: BookingComponent,
      },
      {
        path: 'booked',
        component: BookedComponent,
      },
      {
        path: 'history',
        component: HistoryComponent,
      },
    ],
  },
  { path: '**', component: NotfoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
