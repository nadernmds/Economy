import React, { Component } from "react";
import { Grid, TextField, Container } from "@material-ui/core";
import FullDialog from "../../Widgets/FullDialog/FullDialog";
import ComboBoxBank from "../../Widgets/ComboBoxes/BankCombox";
import ComboBoxCompany from "../../Widgets/ComboBoxes/ComboBoxCompany";
import ComboBoxUserGroup from "../../Widgets/ComboBoxes/ComboBoxUserGroup";
import ComboBoxCity from "../../Widgets/ComboBoxes/ComboBoxCity";
import Item from "../../Widgets/Item/Item";

class UserEdit extends Component {
  state = {  };

  onChange = e => {
    this.setState({ [e.target.name]: e.target.value });
  };
  onSubmit = e => {
    e.preventDefault();
    const formData = { ...this.state };
    fetch("/api/user/" + this.props.id, {
      method: "Put",
      headers: {
        "Content-Type": "application/json"
      },
      body: JSON.stringify(formData)
    }).then(c => {
      if (c.ok) {
        // for (const key in this.state) {
        //   if (this.state.hasOwnProperty(key)) {
        //     this.state[key] = "";
        //   }
        // }
        this.props.update({ ...formData });
      }
    });
  };
  componentDidMount() {
    fetch("api/user/" + this.props.id)
      .then(c => c.json())
      .then(c => this.setState({ ...c }));
  }

  render() {
    return (
      <div>
        <form autoComplete="Off">
          <FullDialog
            value={this.props.value}
            update={this.props.update}
            buttonText="ویرایش"
            OnSave={e => {
              this.onSubmit(e);
            }}
          >
            <br />
            <br />
            <Container>
              <Grid container>
                <input type="hidden" name="id" value={this.props.id} />
                <Item>
                  <TextField
                    value={this.state.username}
                    name="username"
                    label="نام کاربری"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField
                    value={this.state.password}
                    type="password"
                    name="password"
                    label="کلمه عبور"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField
                    value={this.state.email}
                    type="email"
                    name="email"
                    label="ایمیل"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField
                    name="name"
                    label="نام و نام خانوادگی"
                    value={this.state.name}
                    onChange={this.onChange}
                  />
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
                    value={this.state.economyCode}
                    name="economyCode"
                    label="کد اقتصادی"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField
                    value={this.state.mobile}
                    name="mobile"
                    label="شماره موبایل"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField
                    value={this.state.phone}
                    name="phone"
                    label="شماره های تماس"
                    onChange={this.onChange}
                  />
                </Item>
                <Item>
                  <TextField
                    value={this.state.address}
                    name="address"
                    label="نشانی"
                    onChange={this.onChange}
                  />
                </Item>




                <Item>
                  <TextField
                    value={this.state.nationalCode}
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

export default UserEdit;
