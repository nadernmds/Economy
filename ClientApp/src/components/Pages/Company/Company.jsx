import React, { Component } from "react";

import ApiTable from "../../Widgets/Table/ApiTable";
import Table from "../../Widgets/Table/Table";
import Depts from "./Depts";
import Assets from "./Assets";
import { Grid } from "@material-ui/core";
import Loans from "./Loans";
class Comapny extends Component {
  state = {};
  columns = [{ title: "نام شرکت", field: "companyName" },
  { title: "کد شناسه ملی", field: "nationalCode" },
  { title: "زمینه فعالیت ", field: "activityTypeed" },
  { title: "تعداد پرسنل  ", field: "personnelCount" },
  { title: "معرف", field: "representor" },
  { title: " محل شرکت  ", field: "address" },

  { title: " تاریخ مراجعه  ", field: "startDate" }];
  render() {
    return (
      <div>
        <Grid container>
          <Grid item>
          <Depts/>

          </Grid>
          <Grid item>
            <Assets/>
          </Grid>
          <Grid item>
            <Loans/>
          </Grid>
        </Grid>
        <Table
          url="api/company"
          title="شرکت ها"
          primaryKey="companyID"
          columns={this.columns}
        >
          
        </Table>
      </div>
    );
  }
}

export default Comapny;
