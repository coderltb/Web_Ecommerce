import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SystemRoutingModule } from './system-routing.module';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
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
import { PermissionGrantComponent } from './role/permission-grant.component';
import { RoleDetailComponent } from './role/role-detail.component';
import { RoleComponent } from './role/role.component';
import { UserComponent } from './user/user.component';
import { UserDetailComponent } from './user/user-detail.component';
import { PickListModule } from 'primeng/picklist';
import { RoleAssignComponent } from './user/role-assign.component';
import { SetPasswordComponent } from './user/set-password.component';
import { KeyFilterModule } from 'primeng/keyfilter';

@NgModule({
  declarations: [RoleAssignComponent ,RoleComponent, RoleDetailComponent, PermissionGrantComponent, UserComponent, UserDetailComponent, SetPasswordComponent],
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
    SystemRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    CommonModule,
    PickListModule,
    KeyFilterModule
  ],
  entryComponents: [RoleAssignComponent,RoleDetailComponent, PermissionGrantComponent, UserDetailComponent, SetPasswordComponent],
})
export class SystemModule { }
