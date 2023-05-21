import { NgModule } from '@angular/core';
import { RoleRoutingModule } from './role-routing.module';
import { RoleDetailComponent } from './role-detail.component';
import { SharedModule } from 'primeng/api';
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
import { RoleComponent } from './role.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { PermissionGrantComponent } from './permission-grant.component';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [RoleComponent, RoleDetailComponent, PermissionGrantComponent],
  imports: [
    SharedModule,
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
    RoleRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    CommonModule
  ],
  entryComponents: [RoleDetailComponent, PermissionGrantComponent],
})
export class RoleModule {}