import { Component, EventEmitter, Output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { UserService } from '../../Service/user.service';
import { FullNamePipe } from '../../Pipes/full-name.pipe';

@Component({
  selector: 'app-user-list',
  imports: [CommonModule  , FullNamePipe],
  templateUrl: './user-list.component.html',
  styleUrl: './user-list.component.css'
})
export class UserListComponent {

  users: any[] = [];

  @Output() selectedUser = new EventEmitter();
  constructor( private userService: UserService ){}

  ngOnInit(){
    this.userService.getUsers().subscribe( res => this.users= res.results )
    
  }

  onSelect(user:any){
    this.selectedUser.emit(user);
    console.log(user);
  }

}
