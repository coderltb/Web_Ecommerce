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
import {DialogService, DynamicDialogModule} from 'primeng/dynamicdialog';
import { ProductDetailComponent } from './product-detail.component';
import { ReactiveFormsModule } from '@angular/forms';
import {InputNumberModule} from 'primeng/inputnumber';
import {CheckboxModule} from 'primeng/checkbox';
import {InputTextareaModule} from 'primeng/inputtextarea';
import {EditorModule} from 'primeng/editor';
import { ModuleSharedModule } from '../shared/Modules/module-shared/module-shared.module';
import { BadgeModule } from 'primeng/badge';
import {ImageModule} from 'primeng/image';
import {ConfirmDialogModule} from 'primeng/confirmdialog';

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
    ReactiveFormsModule,
    DropdownModule,
    InputTextModule,
    ProgressSpinnerModule,
    InputNumberModule,
    CheckboxModule,
    InputTextareaModule,
    EditorModule,
    DynamicDialogModule,
    ModuleSharedModule,
    BadgeModule,
    ImageModule,
    ConfirmDialogModule
  ],
  entryComponents:[
    ProductDetailComponent
  ]
})
export class ProductModule { }
