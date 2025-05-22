import { Component } from '@angular/core';
import { NgbDropdown, NgbDropdownItem, NgbDropdownMenu, NgbDropdownToggle } from "@ng-bootstrap/ng-bootstrap";
import { RouterLink } from "@angular/router";
import { NgOptimizedImage } from "@angular/common";

@Component({
  selector: 'app-header',
  standalone: true,
    imports: [
        NgbDropdown,
        NgbDropdownToggle,
        NgbDropdownMenu,
        NgbDropdownItem,
        RouterLink,
        NgOptimizedImage
    ],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss'
})
export class HeaderComponent {

}
