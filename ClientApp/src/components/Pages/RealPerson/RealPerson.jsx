import React, { Component } from "react";
import { Grid } from "@material-ui/core";
import Depts from "../Company/Depts";
import Assets from "../Company/Assets";
import Loans from "../Company/Loans";
import Table from "../../Widgets/Table/Table";
import ComboBoxCompany from "../../Widgets/ComboBoxes/ComboBoxCompany";
class RealPerson extends Component {
  state = {};
  columns = [
    { title: "نام و نام خانوادگی", field: "name" },
    { title: "کد ملی", field: "nationalCode" },
    { title: "شماره های تماس", field: "phone" },
    { title: "موبایل", field: "mobile" },
    { title: "آدرس", field: "address" },
    { title: "تحصیلات", field: "education" },
    { title: "مهارت ها", field: "skills" }
  ];

  render() {
    return (
      <div>
        <Grid container>
          <Grid item>
            <Depts />
          </Grid>
          <Grid item>
            <Assets />
          </Grid>
          <Grid item>
            <Loans />
          </Grid>
        </Grid>
        <Table
          url="api/realPerson"
          title="اشخاص حقیقی "
          primaryKey="realPersonID"
          columns={this.columns}
        >
            <ComboBoxCompany  />
        </Table>
      </div>
    );
  }
}

export default RealPerson;
