import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductComponent } from './product.component';
import { ProductRoutingModule } from './product-routing.module';
import { PanelModule } from 'primeng/panel';
import { TableModule } from 'primeng/table';
import { PaginatorModule } from 'primeng/paginator';
import {BlockUIModule} from 'primeng/blockui';
import { ButtonModule } from 'primeng/button';
import {DropdownModule} from 'primeng/dropdown';
import {InputTextModule} from 'primeng/inputtext';
import {ProgressSpinnerModule} from 'primeng/progressspinner';
import {DynamicDialogModule} from 'primeng/dynamicdialog';
import { ProductDetailComponent } from './product-detail.component';

@NgModule({
  declarations: [
    ProductComponent,
    ProductDetailComponent
  ],
  imports: [
    CommonModule,
    ProductRoutingModule,
    PanelModule, 
    TableModule, 
    PaginatorModule,
    BlockUIModule,
    ButtonModule,
    DropdownModule,
    InputTextModule,
    ProgressSpinnerModule
  ],
  entryComponents:[
    ProductDetailComponent
  ]
})
export class ProductModule { }
