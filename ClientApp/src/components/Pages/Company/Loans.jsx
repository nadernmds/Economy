import React, { Component } from 'react';
import FullDialog from '../../Widgets/FullDialog/FullDialog';
import { Container, Grid, TextField } from '@material-ui/core';
import Item from '../../Widgets/Item/Item';
import Table from '../../Widgets/Table/Table';
class Loans extends Component {
    state = {}
    columns = [{ title: 'عنوان', field: 'title' },{ title: 'میزان بدهی', field: 'emount' }]
    render() {
        return (<div>
            <form >
                <FullDialog buttonText='تسهیلات' title='تسهیلات'>
                    <Table url='api/asset' primaryKey='assetID' columns={this.columns} title=' تسهیلات' />
                    {/* <Container >
                        <Grid container>
                            <Item>
                                <TextField
                                    value={this.state.title}
                                    name="title"
                                    label="عنوان بدهی"
                                    onChange={this.onChange}
                                />
                            </Item>
                            <Item>
                                <TextField
                                    value={this.state.emount}
                                    name="emount"
                                    label="میزان بدهی بدهی"
                                    onChange={this.onChange}
                                />
                            </Item>
                        </Grid>
                    </Container> */}
                </FullDialog>

            </form>  </div>);
    }
}

export default Loans;