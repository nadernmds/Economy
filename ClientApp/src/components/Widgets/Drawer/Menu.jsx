import React, { Component } from "react";
import InboxIcon from "@material-ui/icons/MoveToInbox";
import MailIcon from "@material-ui/icons/Mail";
import { Link } from "react-router-dom";
import {
  List,
  Divider,
  ListItemIcon,
  ListItemText,
  ListItem
} from "@material-ui/core";
class Menu extends Component {
  state = {};
  render() {
    return (
      <div>
        <List>
          <ListItem button component={Link} to="/user">
            <ListItemIcon>
              <InboxIcon />
            </ListItemIcon>
            <ListItemText primary="کاربران" />
          </ListItem>
          <ListItem button component={Link} to="/usergroup">
            <ListItemIcon>
              <InboxIcon />
            </ListItemIcon>
            <ListItemText primary="گروه کاربری" />
          </ListItem>
          <ListItem button component={Link} to="/realperson">
            <ListItemIcon>
              <InboxIcon />
            </ListItemIcon>
            <ListItemText primary="اشخاص حقیقی" />
          </ListItem>
          <Divider />
          <ListItem button component={Link} to="/company">
            <ListItemIcon>
              <InboxIcon />
            </ListItemIcon>
            <ListItemText primary=" اشخاص حقوقی" />
          </ListItem>
          <ListItem button component={Link} to="/state">
            <ListItemIcon>
              <InboxIcon />
            </ListItemIcon>
            <ListItemText primary="استان ها" />
          </ListItem>
        </List>
      </div>
    );
  }
}

export default Menu;
