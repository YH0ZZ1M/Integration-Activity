import { Fragment, useState } from 'react';
import { Button, Card, Table, Modal} from 'react-bootstrap';
import classes from './Users.module.css';
import AddUser from '../UI/Modals Forms/AddUser';
import EditUser from '../UI/Modals Forms/EditUser';
import ToggleItem from '../UI/Specials/ToggleItem';

const Users = () =>{
    //Variables for modals. 
    const[addUser, setAddUser] = useState(false);
    const modalAddClose = () => setAddUser(false);
    const modalAddShow = () => setAddUser(true);

    const[deleteUser, setDeleteUser] = useState(false);
    const modalDelClose = () => setDeleteUser(false);
    const modalDelShow = () => setDeleteUser(true);    

    const[updateUser, setUpdateUser] = useState(false);
    const modalUpdClose = () => setUpdateUser(false);
    const modalUpdShow = () => setUpdateUser(true);


    return (
      <Fragment>
      <Card>
      <Table className={classes.table} striped bordered hover size="sm" align='center'>
        <thead className={classes.content} >
          <tr className={classes.trh}>
            <th colSpan={6}>
            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="20" fill="currentColor" class="bi bi-person-fill me-2" viewBox="0 0 16 20">
            <path d="M3 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H3zm5-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6z"/>
            </svg>USERS LIST</th>
          </tr>
          <tr>
            <th className={classes.th1} align-content='center'>Id</th>
            <th>Name</th>
            <th>Email</th>
            <th>Phone</th>
            <th className={classes.th2}>Items</th>
            <th className={classes.th3}>Options</th>
          </tr>
        </thead>
        <tbody className={classes.content}>
          <tr>
            <td>1</td>
            <td>Mark Ruffalo </td>
            <td>Mark@hotmail.com</td> 
            <td>123456789</td>
            <td><ToggleItem></ToggleItem></td>
            <td>
              <Button variant="secondary" size="sm" onClick={modalUpdShow}>
              <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" fill="currentColor" class="bi bi-pencil-fill me-1" viewBox="0 0 16 20">
              <path d="M12.854.146a.5.5 0 0 0-.707 0L10.5 1.793 14.207 5.5l1.647-1.646a.5.5 0 0 0 0-.708l-3-3zm.646 6.061L9.793 2.5 3.293 9H3.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.207l6.5-6.5zm-7.468 7.468A.5.5 0 0 1 6 13.5V13h-.5a.5.5 0 0 1-.5-.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.5-.5V10h-.5a.499.499 0 0 1-.175-.032l-.179.178a.5.5 0 0 0-.11.168l-2 5a.5.5 0 0 0 .65.65l5-2a.5.5 0 0 0 .168-.11l.178-.178z"/>
              </svg>Update</Button>{'  '}
              <Modal show={updateUser} onHide={modalUpdClose}>
              <Modal.Body>  
               <h3>Edit User ${Users.name}</h3>
               <p>Edit the information of ${Users.name}:</p>
               <div>
               <EditUser/> {" "}
               </div>
               <div>
               <p><b>NOTE:</b> To add items to this user:</p>
               <ul>
                 <li>If Item exist add the owner on Items Page</li>
                 <li>If Item does exist, first create it, and the asign it.</li>
               </ul>
               </div>
              </Modal.Body>  
              <Modal.Footer>  
                <Button variant="success">
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" fill="currentColor" class="bi bi-pencil-fill me-1" viewBox="0 0 16 20">
                <path d="M12.854.146a.5.5 0 0 0-.707 0L10.5 1.793 14.207 5.5l1.647-1.646a.5.5 0 0 0 0-.708l-3-3zm.646 6.061L9.793 2.5 3.293 9H3.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.207l6.5-6.5zm-7.468 7.468A.5.5 0 0 1 6 13.5V13h-.5a.5.5 0 0 1-.5-.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.5-.5V10h-.5a.499.499 0 0 1-.175-.032l-.179.178a.5.5 0 0 0-.11.168l-2 5a.5.5 0 0 0 .65.65l5-2a.5.5 0 0 0 .168-.11l.178-.178z"/>
                </svg>Update User</Button> 
                <Button variant="secondary" onClick={modalUpdClose}>
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="20" fill="currentColor" class="bi bi-x-circle-fill me-1" viewBox="0 0 18 20">
                <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM5.354 4.646a.5.5 0 1 0-.708.708L7.293 8l-2.647 2.646a.5.5 0 0 0 .708.708L8 8.707l2.646 2.647a.5.5 0 0 0 .708-.708L8.707 8l2.647-2.646a.5.5 0 0 0-.708-.708L8 7.293 5.354 4.646z"/>
                </svg>Cancel</Button>   
              </Modal.Footer>  
            </Modal>
              <Button variant="danger" size="sm"  onClick={modalDelShow}>
              <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" fill="currentColor" class="bi bi-trash-fill me-1" viewBox="0 0 16 20">
              <path d="M2.5 1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1H3v9a2 2 0 0 0 2 2h6a2 2 0 0 0 2-2V4h.5a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H10a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1H2.5zm3 4a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 .5-.5zM8 5a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7A.5.5 0 0 1 8 5zm3 .5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 1 0z"/>
              </svg>Delete</Button>{'  '}
              <Modal show={deleteUser} onHide={modalDelClose}>
              <Modal.Body>  
               <h3>Are you sure you want to delete ${Users.Name}?</h3>
              </Modal.Body>  
              <Modal.Footer>  
                <Button variant="danger">
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="18" fill="currentColor" class="bi bi-trash-fill me-1" viewBox="0 0 16 20">
                <path d="M2.5 1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1H3v9a2 2 0 0 0 2 2h6a2 2 0 0 0 2-2V4h.5a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H10a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1H2.5zm3 4a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 .5-.5zM8 5a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7A.5.5 0 0 1 8 5zm3 .5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 1 0z"/>
                </svg>Delete</Button> 
                <Button variant="secondary" onClick={modalDelClose}>
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="20" fill="currentColor" class="bi bi-x-circle-fill me-1" viewBox="0 0 18 20">
                <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM5.354 4.646a.5.5 0 1 0-.708.708L7.293 8l-2.647 2.646a.5.5 0 0 0 .708.708L8 8.707l2.646 2.647a.5.5 0 0 0 .708-.708L8.707 8l2.647-2.646a.5.5 0 0 0-.708-.708L8 7.293 5.354 4.646z"/>
                </svg>Cancel</Button>   
              </Modal.Footer>  
            </Modal>
            </td>
          </tr>
          <tr>
            <th colSpan={6}><Button size="sm" variant="success" onClick={modalAddShow}>
            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="20" fill="currentColor" class="bi bi-plus-circle-fill" viewBox="0 0 18 20">
            <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM8.5 4.5a.5.5 0 0 0-1 0v3h-3a.5.5 0 0 0 0 1h3v3a.5.5 0 0 0 1 0v-3h3a.5.5 0 0 0 0-1h-3v-3z"/>
            </svg> Add User</Button>
            <Modal show={addUser} onHide={modalAddClose}>
              <Modal.Body>  
               <h3>Add New User</h3>
               <p>Type in the information of the new user:</p>
               <div>
               <AddUser/> {" "}
               </div>
               <div>
               <p><b>NOTE:</b> To add items to this user:</p>
               <ul>
                 <li>If Item exist add the owner on Items Page</li>
                 <li>If Item does exist, first create it, and the asign it.</li>
               </ul>
               </div>
              </Modal.Body>  
              <Modal.Footer>  
                <Button variant="success">
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="20" fill="currentColor" class="me-1 bi bi-plus-circle-fill" viewBox="0 0 18 20">
                <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM8.5 4.5a.5.5 0 0 0-1 0v3h-3a.5.5 0 0 0 0 1h3v3a.5.5 0 0 0 1 0v-3h3a.5.5 0 0 0 0-1h-3v-3z"/>
                </svg>Add User</Button> 
                <Button variant="secondary" onClick={modalAddClose}>
                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="20" fill="currentColor" class="bi bi-x-circle-fill me-1" viewBox="0 0 18 20">
                <path d="M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM5.354 4.646a.5.5 0 1 0-.708.708L7.293 8l-2.647 2.646a.5.5 0 0 0 .708.708L8 8.707l2.646 2.647a.5.5 0 0 0 .708-.708L8.707 8l2.647-2.646a.5.5 0 0 0-.708-.708L8 7.293 5.354 4.646z"/>
                </svg>Cancel</Button>   
              </Modal.Footer>  
            </Modal>
            </th>
          </tr>
        </tbody>
      </Table>
      </Card>
      </Fragment>
    );
};

export default Users;