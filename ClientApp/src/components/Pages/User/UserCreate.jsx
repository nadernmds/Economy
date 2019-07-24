import React, { Component } from "react";
import {
  Grid,
  TextField,
  Container,
  Button,
  FormControl,
  Select,
  MenuItem,
  InputLabel,
  FormHelperText,
  Input
} from "@material-ui/core";
import FullDialog from "../../Widgets/FullDialog/FullDialog";
import ComboBoxBank from "../../Widgets/ComboBoxes/BankCombox";
import ComboBoxCompany from "../../Widgets/ComboBoxes/ComboBoxCompany";
import ComboBoxUserGroup from "../../Widgets/ComboBoxes/ComboBoxUserGroup";
import ComboBoxCity from "../../Widgets/ComboBoxes/ComboBoxCity";
import Item from "../../Widgets/Item/Item";

class UserCreate extends Component {
  state = { companyId: "", bankId: "" };

  onChange = e => {
    this.setState({ [e.target.name]: e.target.value });
  };
  onSubmit = e => {
    e.preventDefault();
    const formData = { ...this.state };
    console.log(formData);
    fetch("/api/user", {
      method: "POST",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify(formData)
    })
      .then(c => c.json())
      .then(c => {
        // for (const key in this.state) {
        //   if (this.state.hasOwnProperty(key)) {
        //     this.state[key] = "";
        //   }
        // }
        // this.setState({ ...formData });
        this.props.update({ ...c });
      });
  };

  render() {
    return (
      <div>
        <form autoComplete="Off">
          <FullDialog
            value={this.props.value}
            update={this.props.update}
            buttonText="جدید"
            OnSave={e => {
              this.onSubmit(e);
            }}
          >
            <br />
            <br />
            <Container>
              <Grid container>
                <Item>
                  <TextField
                    name="username"
                    label="نام کاربری"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField
                    type="password"
                    name="password"
                    label="کلمه عبور"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField
                    type="email"
                    name="email"
                    label="ایمیل"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField name="name" label="نام" onChange={this.onChange} />
                </Item>

                <Item>
                  <ComboBoxUserGroup
                    value={this.state.userGroupId}
                    onChange={this.onChange}
                    name="userGroupId"
                  />
                </Item>
                <Item>
                  <TextField
                    name="economyCode"
                    label="کد اقتصادی"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField
                    name="mobile"
                    label="شماره موبایل"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField
                    name="phone"
                    label="شماره های تماس"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField
                    name="address"
                    label="نشانی"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField
                    name="nationalCode"
                    label="کد ملی"
                    onChange={this.onChange}
                  />
                </Item>

              </Grid>
            </Container>
          </FullDialog>
        </form>
      </div>
    );
  }
}

export default UserCreate;
