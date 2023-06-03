import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CatalogRoutingModule } from './catalog-routing.module';
import { BadgeModule } from 'primeng/badge';
import { BlockUIModule } from 'primeng/blockui';
import { ButtonModule } from 'primeng/button';
import { CalendarModule } from 'primeng/calendar';
import { CheckboxModule } from 'primeng/checkbox';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { DropdownModule } from 'primeng/dropdown';
import { DynamicDialogModule } from 'primeng/dynamicdialog';
import { EditorModule } from 'primeng/editor';
import { ImageModule } from 'primeng/image';
import { InputNumberModule } from 'primeng/inputnumber';
import { InputTextModule } from 'primeng/inputtext';
import { InputTextareaModule } from 'primeng/inputtextarea';
import { PaginatorModule } from 'primeng/paginator';
import { PanelModule } from 'primeng/panel';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { TableModule } from 'primeng/table';
import { ModuleSharedModule } from '../shared/Modules/module-shared/module-shared.module';
import { ProductAttributeComponent } from './product/product-attribute.component';
import { ProductDetailComponent } from './product/product-detail.component';
import { ProductComponent } from './product/product.component';
import { SharedModule } from 'primeng/api';
import { AttributeDetailComponent } from './attribute/attribute-detail.component';
import { AttributeComponent } from './attribute/attribute.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    ProductComponent,
    ProductDetailComponent,
    ProductAttributeComponent,
    AttributeComponent,
    AttributeDetailComponent,
  ],
  imports: [
    SharedModule,
    CatalogRoutingModule,
    ReactiveFormsModule,
    PanelModule,
    TableModule,
    PaginatorModule,
    BlockUIModule,
    ButtonModule,
    DropdownModule,
    InputTextModule,
    ProgressSpinnerModule,
    DynamicDialogModule,
    InputNumberModule,
    CheckboxModule,
    InputTextareaModule,
    EditorModule,
    ModuleSharedModule,
    BadgeModule,
    ImageModule,
    ConfirmDialogModule,
    CalendarModule,
  ],
  entryComponents: [ProductDetailComponent, ProductAttributeComponent, AttributeDetailComponent],
})
export class CatalogModule { }
