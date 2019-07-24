import React, { Component } from 'react';
import {
    Table,
    TableHead,
    TableRow,
    TableCell,
    TableBody,
    Button,
    Grid,
    Link
} from "@material-ui/core";
class SelectCompany extends Component {
    state = { items: [] }
    render() {
        console.log(this.state)
        return (<div>
            <Table>
                <TableHead>
                    <TableRow>
                        <TableCell>نام شرکت</TableCell>
                        <TableCell> تاریخ مشارکت آستان  </TableCell>
                        <TableCell>وضعیت مشارکت </TableCell>
                    </TableRow>
                </TableHead>
                <TableBody>
                    {this.state.items.map(c => (
                        <TableRow>
                            <TableCell>
                                <Link to={'/selectComapny/' + c.companyId} />
                                {c.companyName}</TableCell>
                            <TableCell>{c.startDate}</TableCell>
                            <TableCell>{c.activityType.type}</TableCell>
                        </TableRow>
                    ))}
                </TableBody>
            </Table>


        </div>);
    }
    componentDidMount() {
        fetch('api/company').then(c => c.json()).then(c => this.setState({ items: c }));
    }
}


export default SelectCompany;