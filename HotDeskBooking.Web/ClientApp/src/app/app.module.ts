import { MaterialModule } from './material.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { MainComponent } from './main/main.component';
import { BookingComponent } from './main/booking/booking.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { BookedComponent } from './main/booked/booked.component';
import { HistoryComponent } from './main/history/history.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MainComponent,
    BookingComponent,
    NotFoundComponent,
    BookedComponent,
    HistoryComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
